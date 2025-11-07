#include <Keyboard.h>
#include <Mouse.h> 

void setup() 
{
  Serial.begin(9600);
  pinMode(2, INPUT_PULLUP); // W
  pinMode(3, INPUT_PULLUP); // S
  pinMode(4, INPUT_PULLUP); // A
  pinMode(5, INPUT_PULLUP); // D
  pinMode(6, INPUT_PULLUP); // E
  pinMode(7, INPUT_PULLUP); // Space
  pinMode(8, INPUT_PULLUP); // AttackButton
  pinMode(9, INPUT_PULLUP); // R
  Keyboard.begin();
  Mouse.begin();
}

void loop() 
{
  // A key
  if (digitalRead(4) == LOW) 
  {
    Serial.println("A pressed");
    Keyboard.press('a');
  } else {
    Keyboard.release('a');
  }

  // W key
  if (digitalRead(2) == LOW) 
  {
    Serial.println("W pressed");
    Keyboard.press('w');
  } else {
    Keyboard.release('w');
  }

  // D key
  if (digitalRead(5) == LOW) 
  {
    Serial.println("D pressed");
    Keyboard.press('d');
  } else {
    Keyboard.release('d');
  }

  // S key
  if (digitalRead(3) == LOW) 
  {
    Serial.println("S pressed");
    Keyboard.press('s');
  } else {
    Keyboard.release('s');
  }

  // E key
  if (digitalRead(6) == LOW) 
  {
    Serial.println("E pressed");
    Keyboard.press('e');
  } else {
    Keyboard.release('e');
  }

 // Attack key
  if (digitalRead(8) == LOW) 
  {
    Serial.println("MouseLeftClick pressed");
    Mouse.press();
  } else {
    Mouse.release();
  }

  // Space Key
  if (digitalRead(7) == LOW) 
  {
    Serial.println("Space pressed");
    Keyboard.press(' ');
  } else {
    Keyboard.release(' ');
  }
}
