﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string make, string model, int horsePower, string registrationNumber) : this()
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {Make}\n");
            sb.Append($"Model: {Model}\n");
            sb.Append($"HorsePower: {HorsePower}\n");
            sb.Append($"RegistrationNumber: {RegistrationNumber}");
            return sb.ToString();
        }
    }
}
