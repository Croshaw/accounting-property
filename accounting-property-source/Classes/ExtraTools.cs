using System.Windows.Forms;

namespace accounting_property_source.Classes
{
    class ExtraTools
    {
        public bool isTBEmptyOrNull(params TextBox[] items)
        {
            bool result = true;
            foreach (TextBox item in items)
                if (string.IsNullOrEmpty(item.Text))
                    result = false;
            return !result;
        }

        public void ClearTB(params TextBox[] items)
        {
            foreach (TextBox item in items)
                item.Clear();
        }
    }
}
