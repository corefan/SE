﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRageMath;

namespace VRageRender
{
    public class MyRenderMessageUpdateRenderEntity : IMyRenderMessage
    {
        public uint ID;
        public Color? DiffuseColor;
        public Vector3? ColorMaskHSV;
        public float Dithering;

        MyRenderMessageType IMyRenderMessage.MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        MyRenderMessageEnum IMyRenderMessage.MessageType { get { return MyRenderMessageEnum.UpdateRenderEntity; } }
    }
}
