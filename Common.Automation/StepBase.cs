using Common.Automation.Elements;

namespace Common.Automation
{
    public class StepBase
    {
        public Browser Browser => StateHolder.CreateObject<Browser>();
        public Button Button => StateHolder.CreateObject<Button>();
        public Link Link => StateHolder.CreateObject<Link>();
        public TextBox TextBox => StateHolder.CreateObject<TextBox>();
        public ComboBox ComboBox => StateHolder.CreateObject<ComboBox>();
        public CheckBox CheckBox => StateHolder.CreateObject<CheckBox>();
    }
}
