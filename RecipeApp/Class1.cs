using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    class Class1
    {

        static RecipeName[] recipes; 

        static int Count;  

        public string ingredientName;

        public string Measurementunit;

        public float MUquantity;

        public int Ingredientcalories;

        public string IngredientfoodGroup;

        public string Stepsdescription;

        public int displayRecipe;

        public int recipeNum ;

        public double Scale;

        public int dr;


        public void AddRecipe(string RecipeName, int ingredientCount, int numsteps) // this code adds a recipe
        {


            recipes = new RecipeName[100000]; 

            Count = 0;
            
            Form2 form2 = new Form2();
            RecipeName recipe = new RecipeName(); 
            

            recipe.Name = RecipeName;

            recipe.Ingredients = new Ingredients[ingredientCount];



            for (int i = 0; i < ingredientCount; i++) // this code stors the ingredient information 

            {
                form2.ShowDialog();

                ingredientName = form2.ingname; // this code declares the variables according to the info entered from the forms
                Measurementunit = form2.mu;
                MUquantity = form2.mquantity;
                Ingredientcalories = form2.calories;
                IngredientfoodGroup = form2.fg;

                Ingredients ingredient = new Ingredients(ingredientName, MUquantity, Measurementunit, Ingredientcalories, IngredientfoodGroup); // this code adds the recipe info to getters and setters 

                recipe.Ingredients[i] = ingredient; // stores the info in an array
  
            }


            recipe.Steps = new RecipeSteps[numsteps]; 

            for (int i = 0; i < numsteps; i++) // this code stors the steps description
            {
                
                Form4 form4 = new Form4();  
                form4.ShowDialog();
                Stepsdescription = form4.description;

                RecipeSteps step = new RecipeSteps(Stepsdescription);
                recipe.Steps[i] = step; 

            }


            recipes[Count] = recipe;
            Count++;

        }




        public void DisplayARecipe() //this code displays the recipe 
        {

            Form5 form5 = new Form5();
            Form6 form6 = new Form6();

            for (int i = 0; i < Count; i++) //this piece of code displays the recipe
            {
                Form5.rtb.SelectedText = Environment.NewLine + Convert.ToString($" {i + 1}. {recipes[i].Name}");
            }
            
            form5.ShowDialog();
            dr = form5.rnum;

            

            if (dr >= 1 && dr <= Count)//this code displays the ingredients
            
            {
                RecipeName chosenRecipe = recipes[dr - 1];

                Form6.rtb.SelectedText = Environment.NewLine + "Recipe"+ Environment.NewLine;
                Form6.rtb.SelectedText = Environment.NewLine + $"Name: {chosenRecipe.Name} " + Environment.NewLine;
                Form6.rtb.SelectedText = Environment.NewLine + "Ingredients : " + Environment.NewLine;
                

                foreach (Ingredients ingredient in chosenRecipe.Ingredients)

                {

                    Form6.rtb.SelectedText = Environment.NewLine + $" {ingredient.IngredientQuantity} {ingredient.IngredientMU} of {ingredient.IngredientName} " + Environment.NewLine;
                    

                }

                Form6.rtb.SelectedText = Environment.NewLine + " Steps:" + Environment.NewLine;
                

                for (int i = 0; i < chosenRecipe.Steps.Length; i++) //this code displays the steps

                {

                    Form6.rtb.SelectedText = Environment.NewLine + $"{i + 1}. {chosenRecipe.Steps[i].info}" + Environment.NewLine;

                }
                Form6.rtb.SelectedText = Environment.NewLine + $"  Calories: {chosenRecipe.TotalCalories()}";
                

                if (chosenRecipe.TotalCalories() > 300) 

                {

                    Form6.rtb.SelectedText = Environment.NewLine + " Calories exceed 300!";

                }
            form6.ShowDialog();

            }
            else
            {

                MessageBox.Show("Option is invalid!", "Error");

            }


        }




        public void ScaleARecipe() // this code scales the recipe quantity
        {
            

            Form7 form8 = new Form7();



            for (int i = 0; i < Count; i++)
            {

                Form7.rtb.SelectedText = Environment.NewLine + ($" {i + 1}. {recipes[i].Name}");
                
            }

            
            form8.ShowDialog();
            recipeNum = form8.rnum;
            Scale = form8.scale;

            if (recipeNum >= 1 && recipeNum <= Count) // this code scales the recipe quantity
            {
                

                RecipeName chosenRecipe = recipes[recipeNum - 1];

                foreach (Ingredients ingredient in chosenRecipe.Ingredients)
                {

                    ingredient.IngredientQuantity *= Scale; // does the calculation to 
                    MessageBox.Show("Scaled successfully", "Confirmation");

                }


            }
            else
            {

                MessageBox.Show("Please Enter a valid number ");

            }

            
            

        }

        public void ResetARecipe() // this code resets the recipe quantity
        {
            Form7 form8 = new Form7();
            recipeNum = form8.rnum;
            Scale = form8.scale;



            if (recipeNum >= 1 && recipeNum <= Count)
            {


                RecipeName chosenRecipe = recipes[recipeNum - 1];

                foreach (Ingredients ingredient in chosenRecipe.Ingredients)
                {

                    ingredient.IngredientQuantity /= Scale;
                    MessageBox.Show("Reset successfully", "Confirmation");

                }


            }



        }

    }


}


        
    

