using System;

public class Class1
{
	public Class1()
	{

	private string _bookName;
	private string _AuthorName;
	private string _PublisherPlatform;
	private int _BookCount;

	public string BookName
	{
		get
		{
			return _bookName;
		}
		set
		{
			if (_bookName.Length > 0)
			{
              _bookName = value;
			}
			else
			{
				_bookName = "Kitap Adı Girilmemiş";
			}
		}

	}
    public string AuthorName
    {
        get
        {
            return _AuthorName;
        }
        set
        {
            if (_AuthorName.Length > 0)
            {
                _AuthorName = value;
            }
            else
            {
                _AuthorName = "Yazar Adı Girilmemiş";
            }
        }

    }
    public string PublisherPlatform
    {
        get
        {
            return _PublisherPlatform;
        }
        set
        {
            if (_PublisherPlatform.Length > 0)
            {
                _PublisherPlatform = value;
            }
            else
            {
                _PublisherPlatform = "Yayın Evi Adı Girilmemiş";
            }
        }

    }

}
