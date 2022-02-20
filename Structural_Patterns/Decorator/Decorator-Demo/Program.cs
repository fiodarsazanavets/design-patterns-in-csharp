using Decorator_Demo;

var gun = new Gun();

gun.Reload();
gun.Shoot();
gun.Shoot();

Console.WriteLine("Applying a silencer.");
var silencer = new Silencer();
silencer.SetGun(gun);
silencer.Shoot();
silencer.Shoot();

Console.WriteLine("Applying an extended magazine.");
var extendedMag = new ExtendedMagazine();
extendedMag.SetGun(silencer);
extendedMag.Reload();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();
extendedMag.Shoot();

Console.ReadKey();