using Newtonsoft.Json;
using System.Collections.Generic;

public class ImdbMovie
{
    [JsonProperty("#IMDB_ID")]
    public string Id { get; set; }

    [JsonProperty("#TITLE")]
    public string Title { get; set; }

    [JsonProperty("#YEAR")]
    public string Year { get; set; }

    [JsonProperty("#ACTORS")]
    public string Actors { get; set; }
}
public class ImdbResponse
{
    [JsonProperty("ok")]
    public bool Ok { get; set; }

    [JsonProperty("description")]
    public List<ImdbMovie> Data { get; set; }
}
