using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace socketProtocol_Library
{
    public enum PacketType
    {

    }
    public enum PacketSendERROR
    {

    }

    [Serializable]
    public class Packet
    {

        public Packet()
        {

        }

    }

    [Serializable]
    public class ClientMessage : Packet
    {

    }

    [Serializable]
    public class ClientProfile : Packet
    {

    }

    [Serializable]
    public class ClientProfileInfo : Packet
    {

    }

    [Serializable]
    public class ClientDrawingInfo : Packet
    {

    }

    [Serializable]
    public class Answer : Packet
    {

    }

    [Serializable]
    public class ClientDrawing : Packet
    {

    }

    [Serializable]
    public class Init : Packet
    {

    }

    [Serializable]
    public class NickName : Packet
    {

    }

    [Serializable]
    public class TurnChange : Packet
    {

    }

    [Serializable]
    public class GameState : Packet
    {
    }

    [Serializable]
    public class Ranking : Packet
    {
    }

}