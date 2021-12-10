using System.Collections;
using System.Collections.Generic;
using System;

[System.Serializable]
public class jsonController
{
    public int id;
    public string email;
    public string first_name;
    public string last_name;
    public string avatar;
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
[System.Serializable]
public class Data
{
  //  public int id { get; set; }
  //  public string email { get; set; }
  //  public string first_name { get; set; }
  //  public string last_name { get; set; }
  //  public string avatar { get; set; }
}
[System.Serializable]
public class Support
{
    public string url { get; set; }
    public string text { get; set; }
}

