namespace ConverterBinding
{
    public partial class MainPageControl
    {
        public static readonly BindableProperty NullableBoolProperty = BindableProperty.Create(
            nameof(NullableBool),
            typeof(bool?),
            typeof(MainPageControl));

        public static readonly BindableProperty BoolProperty = BindableProperty.Create(
            nameof(Bool),
            typeof(bool),
            typeof(MainPageControl));

        public MainPageControl()
        {
            InitializeComponent();
        }
        
        public bool? NullableBool
        {
            get => (bool?)GetValue(NullableBoolProperty);
            set => SetValue(NullableBoolProperty, value);
        }
        
        public bool Bool
        {
            get => (bool) GetValue(BoolProperty);
            set => SetValue(BoolProperty, value);
        }
    }
}