using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class usercontrol_frontside_customerregistration : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Name
    {
        get
        {
            return name.Text;
        }
        set
        {
            name.Text = value;
        }
    }

    public string Sunname
    {
        get
        {
            return sunname.Text;
        }
        set
        {
            sunname.Text = value;
        }
    }

    public string Fødelsdato
    {
        get
        {
            return fødelsdato.Text;
        }
        set
        {
            fødelsdato.Text = value;
        }
    }

    public string Gender
    {
        get
        {
            return gender.SelectedValue;
        }
        set
        {
            gender.SelectedValue = value;
        }
    }

   
    public string Address
    {
        get
        {
            return address.Text;
        }
        set
        {
            address.Text = value;
        }
    }

       //control state function
    int indexValue;
    public int IndexValue
    {
        get
        {
            return indexValue;
        }
        set
        {
            indexValue = value;
        }
    }
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        Page.RegisterRequiresControlState(this);
    }

    protected override object SaveControlState()
    {
        // Invoke the base class's method and
        // get the contribution to control state
        // from the base class.
        // If the indexValue field is not zero
        // and the base class's control state is not null,
        // use Pair as a convenient data structure
        // to efficiently save 
        // (and restore in LoadControlState)
        // the two-part control state
        // and restore it in LoadControlState.

        Object obj = base.SaveControlState();

        if (indexValue != 0)
        {
            if (obj != null)
            {
                return new Pair(obj, indexValue);
            }
            else
            {
                return (indexValue);
            }
        }
        else
        {
            return obj;
        }
    }

    protected override void LoadControlState(object state)
    {
        if (state != null)
        {
           Pair p = state as Pair;
            if (p != null)
            {
                base.LoadControlState(p.First);
                indexValue = (int)p.Second;
            }
            else
            {
                if (state is int)
                {
                    indexValue = (int)state;
                }
                else
                {
                    base.LoadControlState(state);
                }
            }
        }
    }

}
