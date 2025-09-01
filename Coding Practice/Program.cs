string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "@hayworth.com";

displayEmail(corporate);
displayEmail(external, externalDomain);

void displayEmail(string[,] employeeList, string domain = "@contoso.com")
{
    
    // display  email addresses
    for (int i = 0; i < employeeList.GetLength(0); i++)
    {
        string username = (employeeList[i, 0].Substring(0, 2) + employeeList[i, 1]).ToLower();
        Console.WriteLine(username + domain);
    }

}


