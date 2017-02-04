

class camera10MP : cameraInterface
{
	float megaPixels = 10.0;

	void takePhoto()
	{
		// Take A Photo Logic
	}
}

class camera5Mp : cameraInterface
{
	float megaPixels = 5.0;

	void takePhoto()
	{
		// Take A Photo Logic
	}
}

class USAPlug : plugInterface
{
	string type = "USA";

	void charge()
	{
		// charge Logic
	}
}

class EPlug : plugInterface
{
	string type = "E";

	void charge()
	{
		// charge Logic
	}
}

class Samsung : phoneInterface
{
	private camera10MP camera;
	private USAPlug plug;

	void call()
	{
		// call Logic
	}

class Iphone : phoneInterface
{

	private camera5Mp camera;
	private EPlug plug;
	
	void call()
	{
		// call Logic
	}
}

/