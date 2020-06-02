﻿/*
Copyright 2013 George Edwards

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainPro.Core.Types;

namespace DomainPro.Analyst.Types
{
    public class DP_LinkType : DP_ConcreteType
    {
        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            base.Initialize(parentStructure);

            if (Role1Id != Guid.Empty)
            {
                Role1Attached = (DP_ConcreteType)Parent.Parent.FindTypeById(Role1Id);
                Role1Attached.Links.Add(this);
            }
            if (Role2Id != Guid.Empty)
            {
                Role2Attached = (DP_ConcreteType)Parent.Parent.FindTypeById(Role2Id);
                Role2Attached.Links.Add(this);
            }
        }
    }
}
