//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================


namespace FShipping.Data
{
    using System.Collections.Generic;

    public class Role
    {
        public IEnumerable<string> Actions { get; set; }
        public string Name { get; set; }
    }
}