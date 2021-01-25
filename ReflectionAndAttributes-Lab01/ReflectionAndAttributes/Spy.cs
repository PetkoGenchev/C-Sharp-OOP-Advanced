using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsToGet)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder stringBuilder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {className}");

            foreach (FieldInfo field in classFields.Where(f => fieldsToGet.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();
        }


        public string AnalyzeAcessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classfields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] classPrivateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo field in classfields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo methodInfo in classPrivateMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{methodInfo.Name} have to be private!");
            }

            return stringBuilder.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] methodPrivateInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in methodPrivateInfo)
            {
                sb.AppendLine($"{method.Name}");
            }

            return sb.ToString().Trim();

        }



        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] methodInfos = classType.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            foreach (MethodInfo method in methodInfos.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in methodInfos.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }



    }
}
