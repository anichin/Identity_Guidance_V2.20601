//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================


//---------------------------------------------------------------------------------
// Copyright 2010 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License"); 
// You may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, 
// INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR 
// CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, 
// MERCHANTABLITY OR NON-INFRINGEMENT. 

// See the Apache 2 License for the specific language governing 
// permissions and limitations under the License.
//---------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace SL.Phone.Federation.Utilities
{
    internal class GetIdentityProviderListEventArgs : EventArgs
    {
        private Exception _error;
        private IEnumerable<IdentityProviderInformation> _identityProviders;

        internal GetIdentityProviderListEventArgs(IEnumerable<IdentityProviderInformation> identityProviders, Exception e)
        { 
            _error = e;
            _identityProviders = identityProviders; 
        }

        internal Exception Error{  get { return _error; } }

        internal IEnumerable<IdentityProviderInformation> Result{ get { return _identityProviders; } }
    }
}
