void setup() {
  Serial.begin(9400);

}

void loop() {
  int rwd = random(15, 30);
  Serial.println(rwd);
  delay(750);

}
