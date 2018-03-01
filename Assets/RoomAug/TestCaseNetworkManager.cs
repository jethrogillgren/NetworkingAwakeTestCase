using UnityEngine.Networking;


public class TestCaseNetworkManager : NetworkManager
{

    //BUG TEST CASE -  If this function is commented, it works.  If not it errors.
    //There is no Awake in the base class NetworkManager to override.
    private void Awake()        {    }

}
