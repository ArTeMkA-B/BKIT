using System;
using System.Reflection;

namespace BKIT_LAB6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Babin Artem", 18, 50);
            #region usage example
            /*Console.Write(em);
            em.AddWorkedDays(15);
            Console.Write(em);
            em.AddWorkedDays(180);
            Console.Write(em);
            em.PaySalary();
            Console.Write(em);*/
            #endregion

            Type employeeType = typeof(Employee);

            Console.WriteLine("Class Employee info\n\nConstructiors:");
            ConstructorInfo[] constructors = employeeType.GetConstructors();
            foreach (var constructor in constructors)
            {
                string info = (constructor.IsPublic) ? "public " : "private ";
                info += employeeType.Name + "(";
                ParameterInfo[] parameters = constructor.GetParameters();
                for (int i = 0; i != parameters.Length; ++i)
                {
                    info += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                    if (i != parameters.Length - 1)
                        info += ", ";
                }
                info += ");";
                Console.WriteLine("\t" + info);
            }

            Console.WriteLine("Properties:");
            PropertyInfo[] props = employeeType.GetProperties();
            foreach (var prop in props)
            {
                string info = "public " + prop.PropertyType.Name + " " + prop.Name + " { ";
                if (prop.GetMethod.IsPrivate)
                    info += "private ";
                info += "get; ";
                if (prop.SetMethod.IsPrivate)
                    info += "private ";
                info += "set; }";
                Console.WriteLine("\t" + info);
                /*var attributes = prop.GetCustomAttributes(typeof(SpecialPropAttribute), false);
                if (attributes.Length != 0)
                    Console.WriteLine("\t\tThis property has a 'SpecialProp' attribute with ID = " + (attributes[0] as SpecialPropAttribute).Id);*/
            }

            Console.WriteLine("Methods:");
            MethodInfo[] methods = employeeType.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                string info = (method.IsPublic) ? "public " : "private ";
                info += method.ReturnType.Name + " " + method.Name + "(";
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i != parameters.Length; ++i)
                {
                    info += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                    if (i != parameters.Length - 1)
                        info += ", ";
                }
                info += ");";
                Console.WriteLine("\t" + info);
            }

            Console.WriteLine("Properties with 'SpecialProp' attribute:");
            props = employeeType.GetProperties();
            foreach (var prop in props)
            {
                var attributes = prop.GetCustomAttributes(typeof(SpecialPropAttribute), false);
                if (attributes.Length != 0)
                {
                    string info = "public " + prop.PropertyType.Name + " " + prop.Name + " { ";
                    if (prop.GetMethod.IsPrivate)
                        info += "private ";
                    info += "get; ";
                    if (prop.SetMethod.IsPrivate)
                        info += "private ";
                    info += "set; }";
                    Console.WriteLine("\t" + info + " ID = " + (attributes[0] as SpecialPropAttribute).Id);
                }
            }

            Console.WriteLine("\nCalling Employee.ToString() method using reflection:");
            Console.WriteLine(employeeType.GetMethod("ToString").Invoke(Activator.CreateInstance(employeeType, "Ivanov Ivan", 65, 20), null));

            Console.ReadKey();
        }
    }
}
