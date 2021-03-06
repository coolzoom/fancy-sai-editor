﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancySaiEditor.Nodes.ActionNodes
{
    [Node(MenuName = "Summon Gameobject", Type = NodeType.ACTION_SUMMON_GO, AllowedTypes = new NodeType[] { NodeType.PARAM_GAMEOBJECT, NodeType.EVENT, NodeType.TARGET })]
    class SummonGObject : ActionNode
    {
        public SummonGObject()
        {
            Type = NodeType.ACTION_SUMMON_GO;

            //Update text
            NodeName.Content = "Summon Gameobject";

            AddParam<ParamNodes.GObject>(ParamId.PARAM_1, NodeType.PARAM_GAMEOBJECT, "Gameobject");
        }

        public override Node Clone()
        {
            return new SummonGObject();
        }
    }
}
