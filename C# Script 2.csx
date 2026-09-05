foreach (var table in Model.Tables)
{
    if (table.Name == "One Kattameya Overall Measures" ||
        table.Name == "One Kattameya Bank Measures" ||
        table.Name == "One Kattameya Cash Measures" ||
        table.Name == "OK Bank-Wise Measures" ||
        table.Name == "Rihana Overall Measures" ||
        table.Name == "Rihana Bank Measures" ||
        table.Name == "Rihana Cash Measures" ||
        table.Name == "Rihana Bank-Wise Measures" ||
        table.Name == "Skyline Katamya Compound Overall Measures" ||
        table.Name == "Skyline Katamya Compound Bank Measures" ||
        table.Name == "Skyline Katamya Compound Cash Measures" ||
        table.Name == "Skyline Katamya Compound Bank-Wise Measures" ||
        table.Name == "Crystal Plaza Maadi Compound Overall Measures" ||
        table.Name == "Crystal Plaza Maadi Compound Bank Measures" ||
        table.Name == "Crystal Plaza Maadi Compound Cash Measures" ||
        table.Name == "Crystal Plaza Maadi Compound Bank-Wise Measures" ||
        table.Name == "Zahra North Coast Overall Measures" ||
        table.Name == "Zahra North Coast Bank Measures" ||
        table.Name == "Zahra North Coast Cash Measures" ||
        table.Name == "Zahra North Coast Bank-Wise Measures" ||
        table.Name == "Degla Landmark Overall Measures" ||
        table.Name == "Degla Landmark Bank Measures" ||
        table.Name == "Degla Landmark Cash Measures" ||
        table.Name == "Degla Landmark Bank-Wise Measures")
    {
        foreach (var measure in table.Measures)
        {
            string dax = measure.Expression.Trim();

            if (!dax.StartsWith("COALESCE(", StringComparison.OrdinalIgnoreCase))
            {
                measure.Expression = "COALESCE(" + dax + ", 0)";
            }
        }
    }
}