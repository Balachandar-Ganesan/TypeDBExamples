using System;
using FileHelpers;

[DelimitedRecord(",")]
public class Person
{
    public string PhoneNumber;
    public string FirstName;
    public string LastName;
    public string City;
    public int Age;
}
[DelimitedRecord(",")]
public class Company

{
    public string Name;

}
[DelimitedRecord(",")]
public class CustomerPerson
{
    public string Name;
    public string PhoneNumber;
}
[DelimitedRecord(",")]
public class Calls

{
    public string PhoneNumber1;
    public string PhoneNumber2;
    public string StartedAt;
    public int Duration;
}
[DelimitedRecord(" ")]

public class TypeDBLine
{
    public string TQL;
}
class Launcher
{

    static string strOutput = "";
    static string strQuote = "\"";
    static string strEOC = ";";

    public static string GenerateEntityName(string EntityName)
    {
        string GenerateEntityName = "insert $" + EntityName + " isa " + EntityName;
        return GenerateEntityName;
    }

    public static string GenerateAttributeName(string AttributeName)
    {
        string GenerateAttributeName = ",has " + AttributeName + "  ";
        return GenerateAttributeName;
    }

    public static string FormatString(string AttributeValue)
    {
        string FormatString = strQuote + AttributeValue + strQuote;
        return FormatString;
    }


    static public void Main(String[] args)
    {

        
        Console.WriteLine("Start Reading");
        GenerateCompany();
        GeneratePerson();
        GenerateCustomerPerson();
        GenerateCalls();
        Console.WriteLine("Generated TQL Script");

    }

    public static void GenerateCompany()
    {
        var Loadengine = new FileHelperEngine<Company>();
        var Companies = Loadengine.ReadFile("Company.csv");
        var typedblines = new List<TypeDBLine>();
        

        foreach (var Company in Companies)
        {
            TypeDBLine typedbline = new TypeDBLine();
            strOutput = 
                GenerateEntityName("company") +
                GenerateAttributeName("name")+
                FormatString(Company.Name) + 
                strEOC;
            typedbline.TQL = strOutput;
            typedblines.Add(typedbline);            
        }
        var Writeengine = new FileHelperEngine<TypeDBLine>();
        Writeengine.WriteFile("CompanyTQL.txt", typedblines);
    }
    public static void GeneratePerson()
    {
        var Loadengine = new FileHelperEngine<Person>();
        var Persons = Loadengine.ReadFile("Person.csv");
        var typedblines = new List<TypeDBLine>();

        foreach (var Person in Persons)
        {
            TypeDBLine typedbline = new TypeDBLine();
            strOutput =
                GenerateEntityName("person") +
                GenerateAttributeName("phone-number") +
                FormatString(Person.PhoneNumber) +
        GenerateAttributeName("first-name") +
                FormatString(Person.FirstName) +
                GenerateAttributeName("last-name") +
                FormatString(Person.LastName) +
                GenerateAttributeName("city") +
                FormatString(Person.City) +
                GenerateAttributeName("age") +
                Person.Age.ToString() +
                strEOC;

            typedbline.TQL = strOutput;
            typedblines.Add(typedbline);
        }
        var Writeengine = new FileHelperEngine<TypeDBLine>();
        Writeengine.WriteFile("PersonTQL.txt", typedblines);
    }
    public static void GenerateCustomerPerson()
    {
        var Loadengine = new FileHelperEngine<CustomerPerson>();
        var CustomerPersons = Loadengine.ReadFile("CustomerPerson.csv");
        var typedblines = new List<TypeDBLine>();
        strOutput = "";
        foreach (var CustomerPerson in CustomerPersons)
        {
            strOutput = "match $company isa company, has name #Name#; $customer isa person, has phone-number #PhoneNumber#; insert (provider: $company, customer: $customer) isa contract;";

            TypeDBLine typedbline = new TypeDBLine();
            strOutput = strOutput.Replace("#Name#", FormatString(CustomerPerson.Name));
            strOutput = strOutput.Replace("#PhoneNumber#", FormatString(CustomerPerson.PhoneNumber));
            typedbline.TQL = strOutput;
            typedblines.Add(typedbline);
        }
        var Writeengine = new FileHelperEngine<TypeDBLine>();
        Writeengine.WriteFile("CustomerPersonTQL.txt", typedblines);
    }

    public static void GenerateCalls()
    {
        var Loadengine = new FileHelperEngine<Calls>();
        var varCalls = Loadengine.ReadFile("Calls.csv");
        var typedblines = new List<TypeDBLine>();
        strOutput = "";
        foreach (var Call in varCalls)
        {
            strOutput = "match $caller isa person, has phone-number #PhoneNumber1#; $callee isa person, has phone-number #PhoneNumber2#; insert $call(caller: $caller, callee: $callee) isa call; $call has started-at #StartedAt#; $call has duration #Duration#;";

            TypeDBLine typedbline = new TypeDBLine();
            strOutput = strOutput.Replace("#PhoneNumber1#", FormatString(Call.PhoneNumber1));
            strOutput = strOutput.Replace("#PhoneNumber2#", FormatString(Call.PhoneNumber2));
            strOutput = strOutput.Replace("#StartedAt#", Call.StartedAt);
            strOutput = strOutput.Replace("#Duration#", Call.Duration.ToString());
            typedbline.TQL = strOutput;
            typedblines.Add(typedbline);
        }
        var Writeengine = new FileHelperEngine<TypeDBLine>();
        Writeengine.WriteFile("CallsTQL.txt", typedblines);
    }



    
}




