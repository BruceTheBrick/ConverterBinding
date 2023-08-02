namespace ConverterBinding;

public partial class MainPage
{
    public string TextValue { get; set; }
    public string AccessibilityName { get; set; } = string.Empty;
    public bool IsInAccessibleTree { get; set; } = true;
    public MainPage()
    {
        InitializeComponent();
    }
}