String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

void setup() {
  
  Serial.begin(9600);
}

void loop() {
  if(stringComplete) {
    getCommand();
    if(commandString == "LOW") {
      
    }
  }
}




void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(3,6);
  }
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
