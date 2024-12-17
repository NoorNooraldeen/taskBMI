// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.ComponentModel.Design;

Console.WriteLine("enter the weight :");
double weight = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("enter the hight :");
double height =Convert.ToDouble(Console.ReadLine());

height = height / 100; // converting from cm to m
double BMI = weight / ( height * height); // the second part is the equation given 


//2 BMI STATE
string bmiState=""; // declaring a varible

if (BMI < 18.5) {
    bmiState = ("underweight!");
        Console.WriteLine("your BMI status is : " + bmiState + " ");
}
else if (BMI >= 18.5 && BMI <= 24.9)
    bmiState = ("healthy");
else if (BMI >= 25.0 && BMI <= 29.9)
    bmiState = ("overweight");
else if (BMI >= 30.0)
    bmiState = ("obese");

//3



Console.WriteLine("enter the age:");
int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the BMI :");
//double bmi = Convert.ToDouble(Console.ReadLine());

if (age >= 19 && age <= 24 && (BMI >= 19 && BMI <= 24))
{
    bmiState = "healthy";

}

else if (age >= 25 && age <= 34 && (BMI >= 20 && BMI <= 25))
{
    bmiState = "healthy";
}
if (age >= 35 && age <= 44 && (BMI >= 21 && BMI <= 26))
{
    bmiState = "healthy";
}
if (age >= 45 && age <= 54 && (BMI >= 22 && BMI <= 27))
{
    bmiState = "not healthy";
}
if (age >= 55 && age <= 64 && (BMI >= 23 && BMI <= 28))
{
    bmiState = " not healthy";
}
if (age > 65 && (BMI >= 24 && BMI <= 29))
{
    bmiState = " not healthy";
}
Console.WriteLine("your BMI status is : " + bmiState + " ");










