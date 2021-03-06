﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FancySaiEditor.Nodes.ActionNodes
{
    [Node(MenuName = "Cast", Type = NodeType.ACTION_CAST, AllowedTypes = new NodeType[] { NodeType.PARAM_SPELL, NodeType.EVENT, NodeType.TARGET })]
    class Cast : ActionNode
    {
        public Cast()
        {
            Type = NodeType.ACTION_CAST;

            //Update text
            NodeName.Content = "Cast";

            AddParam<CastFlags>(ParamId.PARAM_1, "Flags");
            AddParam<ParamNodes.Spell>(ParamId.PARAM_2, NodeType.PARAM_SPELL, "Spell");
        }

        public override Node Clone()
        {
            return new Cast();
        }
    }
}
