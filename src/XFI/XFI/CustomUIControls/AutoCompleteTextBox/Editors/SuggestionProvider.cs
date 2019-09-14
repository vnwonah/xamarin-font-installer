﻿using System;
using System.Collections;

namespace XFI.CustomUIControls.AutoCompleteTextBox.Editors
{
    public class SuggestionProvider : ISuggestionProvider
    {


        #region Private Fields

        private readonly Func<string, IEnumerable> _method;

        #endregion Private Fields

        #region Public Constructors

        public SuggestionProvider(Func<string, IEnumerable> method)
        {
            _method = method ?? throw new ArgumentNullException(nameof(method));
        }

        #endregion Public Constructors

        #region Public Methods

        public IEnumerable GetSuggestions(string filter)
        {
            return _method(filter);
        }

        IEnumerable ISuggestionProvider.GetSuggestions(string filter)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods

    }
}
