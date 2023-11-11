using Ecommerce.Enums;

namespace Ecommcerce.Web.Admin.Store.Helpers;

public class CommonHelper
{
    public static bool? ConvertStateSelectionToBool(StateSelectionOptions stateSelection)
    {
        switch (stateSelection)
        {
            case StateSelectionOptions.All:
                return null;
            case StateSelectionOptions.Actives:
                return true;
            case StateSelectionOptions.Inactives:
                return false;
            default:
                return null;
        }
    }
    public static StateSelectionOptions ConvertBoolToStateSelection(bool? isActive)
    {
        switch (isActive)
        {
            case null: 
                return StateSelectionOptions.All;

            case true :
                return StateSelectionOptions.Actives;

            case false:
                return StateSelectionOptions.Inactives;
        }
    }
}
