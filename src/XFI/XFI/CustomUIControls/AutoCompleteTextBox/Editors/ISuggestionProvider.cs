using System.Collections;

namespace XFI.CustomUIControls.AutoCompleteTextBox.Editors
{
    public interface ISuggestionProvider
    {

        #region Public Methods

        IEnumerable GetSuggestions(string filter);

        #endregion Public Methods

    }
}
