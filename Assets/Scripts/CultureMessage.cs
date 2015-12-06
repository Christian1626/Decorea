using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CultureMessage
{
    public enum CultureFile
    {
        FR,
        US
    }

    #region Fields

    private TextAsset messageAsset;
    private Dictionary<string, string> messages;

    #endregion

    #region Properties

    public Dictionary<string, string> Messages
    {
        get { return this.messages; }
        set { messages = value; }
    }

    #endregion

    #region Constructors

    public CultureMessage()
    {
        messages = new Dictionary<string, string>();
    }

    #endregion

    #region Methods

    public void LoadMessages()
    {
        LoadMessages(CultureFile.FR);
    }

    public void LoadMessages(CultureFile culture)
    {
        Debug.Log("CultureMessage: LoadMessages with culture " + culture.ToString());
        messageAsset = Resources.Load("AppMessages/" + culture.ToString() + "/messages") as TextAsset;
        if (messageAsset != null)
        {
            messages.Clear();

            string line;
            string[] lines = messageAsset.text.Split('\n');
            int cptLine = 0;

            while (cptLine <= lines.Length - 1)
            {
                line = lines[cptLine];
                string[] values = line.Split('|');

                if (!messages.ContainsKey(values[0]))
                    messages.Add(values[0], values[1]);
                else
                    Debug.LogError("CultureMessage: language file has redondant keys !");

                cptLine++;
            }
        }
        else
            Debug.LogError("CultureMessage: Cannot found relative language file !");

    }

    public string GetMessage(string key)
    {
        string msg = string.Empty;
        if (Messages.TryGetValue(key, out msg))
            return msg;
        else
            return string.Empty;
    }

    #endregion
}
