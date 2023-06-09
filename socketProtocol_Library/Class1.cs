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
        메세지 = 0,
        닉네임,
        프로필,
        프로필정보,
        그림,
        그림정보,
        턴,
        정답,
        초기화,
        게임상태,
        랭킹,
        랭킹프로필
    }
    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }

    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }
        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            byte[] bytes = ms.ToArray();
            ms.Flush();
            return bytes;
        }

        public static Object Deserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }

    }

    [Serializable]
    public class ClientMessage : Packet //메세지 전송-> PacketType.메세지
    {
        public string nickName;
        public string Message;
        public ClientMessage()
        {
            nickName = null;
            Message = null;
        }
    }

    [Serializable]
    public class ClientProfile : Packet //메세지 전송-> PacketType.프로필
    {
        public string nickName;
        public byte[] buffer;
        public int count;
        public int clientNum;

        public ClientProfile()
        {
            nickName = null;
            count = 0;
            buffer = new byte[1024];
            clientNum = 0;
        }
    }

    [Serializable]
    public class ClientProfileInfo : Packet //메세지 전송-> PacketType.프로필
    {
        public int clientNum;

        public ClientProfileInfo()
        {
            clientNum = 0;
        }
    }

    [Serializable]
    public class ClientDrawingInfo : Packet //그림 전송-> PacketType.그림
    {
        public int clientNum;

        public ClientDrawingInfo()
        {
            clientNum = 0;
        }
    }

    [Serializable]
    public class Answer : Packet //그림 전송-> PacketType.그림
    {
        public string answer;

        public Answer()
        {
            answer = null;
        }
    }

    [Serializable]
    public class ClientDrawing : Packet //그림 전송->PacketType.그림
    {
        public byte[] buffer;
        public int count;
        public int clientNum;

        public ClientDrawing()
        {
            count = 0;
            buffer = new byte[1024];
            clientNum = 0;
        }
    }

    [Serializable]
    public class Init : Packet // 클라이언트 정보 전송-> PacketType. 초기화
    {
        public int clinetNumber;
        public string[] nickNameList;
        public int client_sum;
        public Init()
        {
            client_sum = 0;
            clinetNumber = 0;
            nickNameList = new string[4];
        }
    }

    [Serializable]
    public class NickName : Packet //클라이언트 정보 전송-> PacketType.초기화
    {
        public string[] nickNameList;
        public int client_sum;
        public NickName()
        {
            client_sum = 0;
            nickNameList = new string[4];
        }
    }

    [Serializable]
    public class TurnChange : Packet //정답,오답 구분과 함께 턴 전송 -> PacketType.정답, 턴
    {
        public int turn;
        public string message;
        public string Word;
        public bool Correct;
        public int score;
        public int[] clientscore;
        public int turnCount;
        public int clientNum;

        public TurnChange()
        {
            turn = 0;
            message = null;
            Word = null;
            Correct = false;
            score = 0;
            clientNum = 0;
            clientscore = new int[] { 0, 0, 0, 0 };
            turnCount = 3;
        }
    }

    [Serializable]
    public class GameState : Packet //게임 시작과 끝 정보 전송 -> PacketType.게임상태
    {
        public bool gameStart;
        public string message;

        public GameState()
        {
            gameStart = false;
            message = null;
        }
    }

    [Serializable]
    public class Ranking : Packet //랭킹
    {
        public int[] clientscore;
        public string[] clientNickname;
        public int clientSum;

        public Ranking()
        {
            clientscore = new int[] { 0, 0, 0, 0 };
            clientNickname = new string[] { "", "", "", "" };
            clientSum = 0;
        }
    }

    sealed class AllowAllAssemblyVersionDewerializationBinder : System.Runtime.Serialization.SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = null;
            String currentAssembly = System.Reflection.Assembly.GetExecutingAssembly().FullName;
            assemblyName = currentAssembly;
            typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));
            return typeToDeserialize;
        }
    }
}