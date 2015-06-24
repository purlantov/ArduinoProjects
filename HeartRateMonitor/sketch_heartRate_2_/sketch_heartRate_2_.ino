//VARIABLES
int data;

//SETUP
void setup(){
  Serial.begin(9600);//for the processing sketch
  
}

//LOOP
void loop(){
    data = analogRead(0);//now write the next analog value to data[0]
    Serial.println(data);//send over the current value to the processing sketch, but scale it to match the screen height
    delay(2); 
}



