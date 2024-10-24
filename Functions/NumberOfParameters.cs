﻿class NumberOfParameters
{
    private GameDataWriter _gameDataWriter = new GameDataWriter();

    public void SaveGame( //too many parameters - should be split (see code below)
        GameData data,
        string saveFileName,
        string saveFileExtension)
    {
        var saveFileFinalPath = saveFileName + "." + saveFileExtension;

        _gameDataWriter.WriteTo(saveFileFinalPath, data);
    }

    //better - now the method  has only two parameters
    //and it is the BuildFileName method that is responsible for building a file name
    public void SaveGame( 
        GameData data,
        string saveFileName)
    {
        _gameDataWriter.WriteTo(saveFileName, data);
    }

    public string BuildFileName(
        string saveFileName,
        string saveFileExtension)
    {
        return saveFileName + "." + saveFileExtension;
    }

    public IDatabaseConnection ConnectToDatabase( // too many parameters - should be bundled (see code below)
        string userName,
        string password,
        string databaseName,
        string databaseServerName,
        string databaseClusterName)
    {
        throw new NotImplementedException();
    }

    public IDatabaseConnection ConnectToDatabase( //better - only 3 parameters
        string userName,
        string password,
        DatabaseIdentity databaseIdentity)
    {
        throw new NotImplementedException();
    }

    public IDatabaseConnection ConnectToDatabase( //best - only 2 parameters
        UserCredentials userCredentials,
        DatabaseIdentity databaseIdentity)
    {
        throw new NotImplementedException();
    }

    public struct DatabaseIdentity
    {
        public string DatabaseName;
        public string DatabaseServerName;
        public string DatabaseClusterName;
    }

    public struct UserCredentials
    {
        public string UserName;
        public string Password;
    }
}

public struct Circle_TooManyParams
{
    public float X { get; }
    public float Y { get; }
    public float Radius { get; }

    //too many parameters - x and y should be bundled (see the code below)
    public Circle_TooManyParams(float x, float y, float radius) 
    {
        X = x;
        Y = y;
        Radius = radius;
    }
}

public struct Circle
{
    public Point Center { get; }
    public float Radius { get; }

    public Circle(Point center, float radius) //better - only 2 parameters
    {
        Center = center;
        Radius = radius;
    }
}

public struct Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

class GameData
{

}

class GameDataWriter
{
    public void WriteTo(string saveFileFinalPath, GameData data)
    {
    }
}

public interface IDatabaseConnection
{

}