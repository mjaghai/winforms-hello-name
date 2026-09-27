# WinForms — Hello Name

A first Windows Forms app: type a name, press a button, get a greeting. Small, but it
covers the event handling and control-state basics every WinForms project builds on.

```
HelloName/
├── HelloName.sln
├── HelloName/
│   ├── HelloName.csproj
│   ├── Form1.cs           ← all the interesting code
│   ├── Form1.Designer.cs  ← control layout
│   ├── Form1.resx
│   ├── Program.cs
│   └── Properties/
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| `TextChanged` — reacting on every keystroke | `txtYourname_TextChanged` |
| **Enabling/disabling buttons from code** | same |
| `Convert.ToBoolean(...)` to drive `Enabled` directly | same |
| `MouseMove` / `MouseLeave` — hover effects | `lblYourname_MouseMove`, `lblYourname_MouseLeave` |
| Changing `ForeColor` in response | same |
| `Focus()` — move the caret to a control | `btnClear_Click` |
| Calling a handler manually from `Load` | `Form1_Load` |
| `Application.Exit()` | `btnExit_Click` |

The pattern worth stealing is the one in `txtYourname_TextChanged`: the buttons stay
in a correct state on every keystroke rather than only when a button is clicked.

```csharp
private void txtYourname_TextChanged(object sender, EventArgs e)
{
    if (txtYourname.Text == "")
        btnSayhello.Enabled = false;
    else
        btnSayhello.Enabled = true;

    btnClear.Enabled = Convert.ToBoolean(txtYourname.Text.Length);
}
```

## Running it

This is a **.NET Framework 4.7.2** Windows Forms app — Windows only.

Open `HelloName.sln` in Visual Studio and press F5.

```bash
# or from a Visual Studio Developer Command Prompt
msbuild HelloName.sln /p:Configuration=Release
HelloName\bin\Release\HelloName.exe
```

## Notes

Originally named `WindowsFormsApp1` (the Visual Studio default) — renamed to
`HelloName`, along with the project, assembly and namespace.

---

<div dir="rtl">

## WinForms — سلام کردن به نام کاربر

یک برنامه ساده WinForms: نامی را وارد کنید، دکمه را بزنید و سلام را ببینید.

**مفاهیمی که نشان می‌دهد:**

- **رویداد `TextChanged`** — واکنش به هر بار تایپ
- **فعال و غیرفعال کردن دکمه‌ها از داخل کد** (`Enabled`)
- **رویدادهای `MouseMove` و `MouseLeave`** برای افکت هاور
- **تغییر رنگ متن** (`ForeColor`) در واکنش به رویداد
- **انتقال فوکوس** با `Focus()`

نکته مهم این پروژه الگوی `txtYourname_TextChanged` است: دکمه‌ها در **هر بار تایپ**
به‌روز می‌شوند، نه فقط وقتی دکمه‌ای زده می‌شود.

**اجرا:** نیازمند ویندوز و Visual Studio.

</div>
