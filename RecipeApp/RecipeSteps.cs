﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeSteps // this code stores the steps of the recipe
    {
        public string info 
        { 
            get; 
        }

        public RecipeSteps(string stepinfo)
        {

            info = stepinfo;
        
        }
    }
}
