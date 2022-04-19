using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputData = input.Split(" -> ");
                string companyName = inputData[0];
                string employeeID = inputData[1];
                if (companies.ContainsKey(companyName))
                {
                    bool isDublicated = false;
                    for (int i = 0; i < companies[companyName].Count; i++)
                    {
                        if (employeeID == companies[companyName][i])
                        {
                            isDublicated = true;
                            break;
                        }
                    }
                    if (!isDublicated)
                    {
                        companies[companyName].Add(employeeID);
                    }
                }
                else
                {
                    List<string> employees = new List<string> { employeeID };
                    companies.Add(companyName, employees);
                }
                input = Console.ReadLine();

            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
