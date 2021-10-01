using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class UserRegistrationReflection
    {

        /// <summary>
        /// Create object of RegularExpression
        /// </summary>
        /// <param name="className"></param>
        /// <param name="construtorName"></param>
        /// <returns></returns>
        public static object CreateUserRegistration(string className, string construtorName)
        {
            string pattern = @"." + construtorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionName.No_Such_Class, "Class not found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionName.No_Such_Method, "Constructor is not found");
            }
        }
    
        //public static string InvokeRegularExpressionMethod(string methodName, string parameterValue)
        //{
        //    Type mType = Type.GetType("UserRegistrationRegex.RegularExpression");
        //    ConstructorInfo magicConstructor = mType.GetConstructor(Type.EmptyTypes);
        //    object magicClassObject = magicConstructor.Invoke(new object[] { });

        //    MethodInfo magicMethod = mType.GetMethod(methodName);
        //    object magicValue = magicMethod.Invoke(magicClassObject, new object[] { parameterValue });
        //    return magicValue.ToString();
        //}
    }
}
