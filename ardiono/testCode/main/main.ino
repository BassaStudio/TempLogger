const int SenserPin = 0;

const int Red = 11;
const int Yellow = 10;
const int Green = 9;

String inputString = "";
String commandString = "";
bool stringComplete = false;


void setup() {
  Serial.begin(9400);

  pinMode(Red, OUTPUT);
  pinMode(Yellow, OUTPUT);
  pinMode(Green, OUTPUT);
}

void loop() {
  Serial.println(getTemp());
  delay(750);

  if (stringComplete == true)
  {
    getCommand();
    //Serial.println(commandString);
    commandt();
    inputString = "";
    stringComplete = false; 
  }
}

void commandt() {
  if(commandString == "LOW")
    {
      digitalWrite(Red, LOW);
      digitalWrite(Yellow, HIGH);
      digitalWrite(Green, LOW);
    } 
    else if(commandString == "HOT")
    {
      digitalWrite(Red, HIGH);
      digitalWrite(Yellow, LOW);
      digitalWrite(Green, LOW);
    } 
      else if(commandString == "NOR")
    {
      digitalWrite(Red, LOW);
      digitalWrite(Yellow, LOW);
      digitalWrite(Green, HIGH);  
    }
}

float getTemp() {
  float value = analogRead(SenserPin);
  float mv = (value/ 1024.0) * 5000;
  float celsius = mv/10;
  return celsius; 
}

void serialEvent() {
  while (Serial.available()) {

    char inChar = (char)Serial.read();
    
    inputString += inChar;
    //Serial.println(inChar);

    if (inChar == '?') {
      //Serial.println(inputString);
      stringComplete = true;
    }
  }
}

void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(0,3);
  }
}
