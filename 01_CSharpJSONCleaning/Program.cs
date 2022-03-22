using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpJSONCleaning
{

  class Program
  {
    static void Main(string[] args)
    {
      // {"name":{"first":"Robert","middle":"","last":"Smith"},"age":25,"DOB":"-","hobbies":["running","coding","-"],"education":{"highschool":"N\/A","college":"Yale"}}
      string json = GetJSONAsync().Result;

      Console.WriteLine(json);

      json = ProcessJsonResponse(json);

      Console.WriteLine(json);
    }

    private static string ProcessJsonResponse(string json)
    {
      json = json.Replace("N\\/A", "NA");
      string regExToRemoveEmptyItems = "(\"\\w+\"\\s{0,}:\\s{0,}(\"\"|\"[-]\"|\"NA\")\\s{0,},{0,})|(\"-\"\\s{0,},|,\\s{0,}\"-\")";
      string result = Regex.Replace(json, regExToRemoveEmptyItems, "");

      return result;
    }

    private async static Task<string> GetJSONAsync()
    {
      string content = "";

      using (HttpClient client = new HttpClient())
      using (HttpResponseMessage response = await client.GetAsync("https://coderbyte.com/api/challenges/json/json-cleaning"))
      {
        if (response.IsSuccessStatusCode)
        {
          content = await response.Content.ReadAsStringAsync();
        }
      }

      return content;
    }
  }
}

// Input

/*
{
  "name": {
    "first": "Robert",
    "middle": "",
    "last": "Smith"
  },
  "age": 25,
  "DOB": "-",
  "hobbies": ["running", "coding", "-"],
  "education": {
    "highschool": "N\/A",
    "college": "Yale"
  }
}
*/

// Expected result

/*
{
  "name": {
    "first": "Robert",
    "last": "Smith"
  },
  "age": 25,
  "hobbies": ["running", "coding"],
  "education": {
    "college": "Yale"
  }
}
*/