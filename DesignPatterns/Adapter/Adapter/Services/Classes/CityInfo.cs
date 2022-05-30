using System.ComponentModel;

namespace Adapter;

public class CityInfo
{
    [DisplayName("SearchMetada")]
    public Search_Metadata search_metadata { get; set; }
    public Search_Parameters search_parameters { get; set; }
    public Search_Information search_information { get; set; }
    public Images_Results[] images_results { get; set; }
}


public class Search_Metadata
{
    public string id { get; set; }
    public string status { get; set; }
    public string json_endpoint { get; set; }
    public string created_at { get; set; }
    public string processed_at { get; set; }
    public string google_url { get; set; }
    public string raw_html_file { get; set; }
    public float total_time_taken { get; set; }
}

public class Search_Parameters
{
    public string engine { get; set; }
    public string q { get; set; }
    public string google_domain { get; set; }
    public string ijn { get; set; }
    public string device { get; set; }
    public string tbm { get; set; }
}

public class Search_Information
{
    public string image_results_state { get; set; }
    public string query_displayed { get; set; }
}

public class Images_Results
{
    public int position { get; set; }
    public string thumbnail { get; set; }
    public string source { get; set; }
    public string title { get; set; }
    public string link { get; set; }
    public string original { get; set; }
    public bool is_product { get; set; }
}
