using UnityEngine.Networking;

public class TestCaseNetworkDiscovery : NetworkDiscovery
{

    private void Awake() {   }

    private void Start()
    {
        Initialize();


        //Starting as client, we will see the error repeatedly
        StartAsClient();

        //Starting as Server, we see it only on exit
        //StartAsServer();
    }

}
