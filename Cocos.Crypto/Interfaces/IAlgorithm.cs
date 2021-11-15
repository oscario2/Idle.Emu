namespace Cocos.Crypto.Interfaces
{
    public interface IAlgorithm
    {
        byte[] Encrypt(byte[] data, byte[] key);
        
        byte[] Decrypt(byte[] data, byte[] key);
    }
}