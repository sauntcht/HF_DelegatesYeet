using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_DelegatesYeet
{
    internal class Adrian
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return AddAdriansSecretIngredient;
            }
        }
        private string AddAdriansSecretIngredient(int amount) {
            return $"{amount} ounces of cloves";
        
        }
    }
}
