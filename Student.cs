﻿using System;

namespace BinarySerializer
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}