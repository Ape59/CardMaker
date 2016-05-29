using System;
using System.IO;
using System.Xml.Serialization;

namespace CardMakerLib
{
	public class CardMaker
	{
		#region Members
		private CardMakerData m_Data = new CardMakerData();

		private string m_strDataPath = string.Empty;
		private string m_strError = string.Empty;
		#endregion

		#region Get/Set
		public CardMakerData Data
		{
			get { return m_Data; }
		}

		public string Error
		{
			get { return m_strError; }
		}
		#endregion

		#region LoadData
		public bool LoadData()
		{
			return LoadData(m_strDataPath);
		}

		public bool LoadData(string f_strDataPath)
		{
			bool bOK = false;
			XmlSerializer serializer = null;
			StreamReader stream = null;

			try
			{
				m_strError = string.Empty;
				m_strDataPath = f_strDataPath;

				serializer = new XmlSerializer(typeof(CardMakerData));
				stream = new StreamReader(f_strDataPath);

				m_Data = (CardMakerData)serializer.Deserialize(stream);
				bOK = true;
			}
			catch (Exception ex)
			{
				m_strError = ex.Message;
			}
			finally
			{
				if(stream != null)
				{
					stream.Close();
				}
			}

			return bOK;
		}
		#endregion

		#region SaveData
		public bool SaveData()
		{
			return SaveData(m_strDataPath);
		}

		public bool SaveData(string f_strDataPath)
		{
			bool bOK = false;
			XmlSerializer serializer = null;
			StreamWriter stream = null;

			try
			{
				m_strError = string.Empty;
				m_strDataPath = f_strDataPath;

				serializer = new XmlSerializer(typeof(CardMakerData));
				stream = new StreamWriter(f_strDataPath);

				serializer.Serialize(stream, m_Data);
				bOK = true;
			}
			catch (Exception ex)
			{
				m_strError = ex.Message;
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			return bOK;
		}
		#endregion
	}
}
