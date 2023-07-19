namespace ConverterBinding;

public partial class MainPage
{
    public string AccessibilityName { get; set; }
    public bool IsInAccessibleTree { get; set; }
    public MainPage()
    {
        InitializeComponent();
        InitializeProperties();
    }

    private void InitializeProperties()
    {
        AccessibilityName = string.Empty;
        IsInAccessibleTree = true;
    }
}