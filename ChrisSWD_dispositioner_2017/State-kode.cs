//FlashLight.cs
public void Power()
{
	_state.HandlePower(this);
}

//Off.cs
public void HandlePower(FlashLight fl)
{
	fl.setState(new On);
}

//FlashLight.cs
public void setState(State newState)
{
	_state.OnExit(); //På nuværende state (Off)
	_state = newState; //Ændrer State (fra Off til On)
	_state = OnEntry(); //Kalder OnEntry (for On)
}