
namespace ex1
{
    public class CookieStore
    {

        public HelloWorldCookie CreateHelloWorldCookie()
        {
            CookieDough cookieDough = MixDough();
            SheetOrLaminateDough(cookieDough);
            FormDough(cookieDough);
            Cookie cookie = BakeDough(cookieDough);

            FillCookie(cookie);
            CoolCookie(cookie);
            FreezeCookie(cookie);
            HelloWorldCookie helloWorldCookie = PackCookie(cookie);
            return helloWorldCookie;
        }

        private CookieDough MixDough()
        {
            Utils.Process();
            return CookieDoughIngredients.Mix();
        }

        private CookieDough SheetOrLaminateDough(CookieDough cookieDough)
        {
            return cookieDough.SheetOrLaminate();
        }

        private CookieDough FormDough(CookieDough cookieDough)
        {
            return cookieDough.PlaceInForm();
        }

        private Cookie BakeDough(CookieDough cookieDough)
        {
            return cookieDough.Bake();
        }

        private Cookie FillCookie(Cookie cookie)
        {
            return cookie.Fill();
        }

        private Cookie CoolCookie(Cookie cookie)
        {
            return cookie.Cool();
        }

        private Cookie FreezeCookie(Cookie cookie)
        {
            return cookie.Freeze();
        }

        private HelloWorldCookie PackCookie(Cookie cookie)
        {
            return cookie.Pack();
        }

    }
}
