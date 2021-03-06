﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancySaiEditor.Nodes.EventNodes
{
    /// <summary>
    /// SMART_EVENT_SET_DATA
    ///
    /// </summary>
    [Node(MenuName = "Data set", Type = NodeType.EVENT_DATA_SET, AllowedTypes = new NodeType[] { NodeType.AI_OWNER, NodeType.ACTION })]
    public class DataSet : EventNode
    {
        /// <summary>
        /// Standard constructor.
        /// Initializes type, node name, tooltips and adds the connectors.
        /// </summary>
        public DataSet()
        {
            Type = NodeType.EVENT_DATA_SET;

            

            //Update text
            NodeName.Content = "Data set";

            AddParam(ParamId.PARAM_1, "Field:");
            AddParam(ParamId.PARAM_2, "Value:");
            AddParam(ParamId.PARAM_3, "Cooldown min:");
            AddParam(ParamId.PARAM_4, "Cooldown max:");
        }

        /// <summary>
        /// Clones the class instance.
        /// </summary>
        /// <returns>Returns clone of this class.</returns>
        public override Node Clone()
        {
            return new DataSet();
        }
    }
}
