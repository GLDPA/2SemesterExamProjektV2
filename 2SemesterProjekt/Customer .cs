﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using InMemoryStorage.Interfaces;

namespace _2SemesterProjekt
{
   public class Customer : IStorable, ITransformed<Customer>
   {
       
        public int Key { get; set; }
       public ITransformed<Customer> Clone()
       {
           throw new NotImplementedException();
       }

       public void SetValuesFromObject(Customer obj)
       {
           throw new NotImplementedException();
       }
   }
}