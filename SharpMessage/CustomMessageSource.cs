using System.Windows.Forms;

namespace SharpMessage
{
    public struct CustomMessage
	{
		public readonly string
			Title,
			Message;
		public readonly MessageBoxButtons Buttons;
		public readonly MessageBoxIcon Icon;

		private const string defaulttitle = "New Message";
		private const MessageBoxButtons defaultbuttons = MessageBoxButtons.OK;
		private const MessageBoxIcon defaulticon = MessageBoxIcon.Information;
		private static readonly MessageBoxIcon erroricon = MessageBoxIcon.Error;

		public CustomMessage(string Message)
		{
			this.Message = Message;
			Title = defaulttitle;
			Buttons = defaultbuttons;
			Icon = defaulticon;
		}
		public CustomMessage(string Message, string Title) : this(Message)
		{
			this.Title = Title;
			Buttons = defaultbuttons;
			Icon = defaulticon;
		}
		public CustomMessage(string Message, MessageBoxButtons Buttons) : this(Message)
		{
			Title = defaulttitle;
			this.Buttons = Buttons;
			Icon = defaulticon;
		}
		public CustomMessage(string Message, MessageBoxIcon Icon) : this(Message)
		{
			Title = defaulttitle;
			Buttons = defaultbuttons;
			this.Icon = Icon;
		}
		public CustomMessage(string Message, string Title, MessageBoxButtons Buttons) : this(Message, Title)
		{
			this.Buttons = Buttons;
			Icon = defaulticon;
		}
		public CustomMessage(string Message, string Title, MessageBoxIcon Icon) : this(Message, Title)
		{
			Buttons = defaultbuttons;
			this.Icon = Icon;
		}
		public CustomMessage(string Message, string Title, MessageBoxButtons Buttons, MessageBoxIcon Icon) : this(Message, Title, Buttons)
		{
			this.Icon = Icon;
		}
		public CustomMessage(string Message, MessageBoxButtons Buttons, MessageBoxIcon Icon) : this(Message, Buttons)
		{
			Title = defaulttitle;
			this.Icon = Icon;
		}

		public void Display()
		{
			MessageBox.Show(Message, Title, Buttons, Icon);
		}
		public DialogResult GetInput()
		{
			return MessageBox.Show(Message, Title, Buttons, Icon);
		}

		public static void NotifyError(string ErrorMessage)
		{
			new CustomMessage(ErrorMessage, "Error Detected", erroricon).Display();
		}
		public static void NotifyError(string ErrorMessage, MessageBoxButtons Input)
		{
			new CustomMessage(ErrorMessage, "Error Detected", Input, erroricon).Display();
		}

		public static DialogResult NotifyErrorWithInput(string ErrorMessage)
		{
			return new CustomMessage(ErrorMessage, "Error Detected", erroricon).GetInput();
		}
		public static DialogResult NotifyErrorWithInput(string ErrorMessage, MessageBoxButtons Input)
		{
			return new CustomMessage(ErrorMessage, "Error Detected", Input, erroricon).GetInput();
		}

		public static void Display(string Message)
		{
			new CustomMessage(Message).Display();
		}
		public static void Display(string Message, string Title)
		{
			new CustomMessage(Message, Title).Display();
		}
		public static void Display(string Message, MessageBoxButtons Buttons)
		{
			new CustomMessage(Message, Buttons).Display();
		}
		public static void Display(string Message, MessageBoxIcon Icon)
		{
			new CustomMessage(Message, Icon).Display();
		}
		public static void Display(string Message, string Title, MessageBoxButtons Buttons)
		{
			new CustomMessage(Message, Title, Buttons).Display();
		}
		public static void Display(string Message, string Title, MessageBoxIcon Icon)
		{
			new CustomMessage(Message, Title, Icon).Display();
		}
		public static void Display(string Message, string Title, MessageBoxButtons Buttons, MessageBoxIcon Icon)
		{
			new CustomMessage(Message, Title, Buttons, Icon).Display();
		}
		public static void Display(string Message, MessageBoxButtons Buttons, MessageBoxIcon Icon)
		{
			new CustomMessage(Message, Buttons, Icon).Display();
		}

		public static DialogResult GetInput(string Message)
		{
			return new CustomMessage(Message).GetInput();
		}
		public static DialogResult GetInput(string Message, string Title)
		{
			return new CustomMessage(Message, Title).GetInput();
		}
		public static DialogResult GetInput(string Message, MessageBoxButtons Buttons)
		{
			return new CustomMessage(Message, Buttons).GetInput();
		}
		public static DialogResult GetInput(string Message, MessageBoxIcon Icon)
		{
			return new CustomMessage(Message, Icon).GetInput();
		}
		public static DialogResult GetInput(string Message, string Title, MessageBoxButtons Buttons)
		{
			return new CustomMessage(Message, Title, Buttons).GetInput();
		}
		public static DialogResult GetInput(string Message, string Title, MessageBoxIcon Icon)
		{
			return new CustomMessage(Message, Title, Icon).GetInput();
		}
		public static DialogResult GetInput(string Message, string Title, MessageBoxButtons Buttons, MessageBoxIcon Icon)
		{
			return new CustomMessage(Message, Title, Buttons, Icon).GetInput();
		}
		public static DialogResult GetInput(string Message, MessageBoxButtons Buttons, MessageBoxIcon Icon)
		{
			return new CustomMessage(Message, Buttons, Icon).GetInput();
		}
	}
}
