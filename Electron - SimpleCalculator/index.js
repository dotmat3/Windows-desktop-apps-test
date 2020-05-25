const { app, BrowserWindow } = require("electron");

const createWindow = () => {
	let win = new BrowserWindow({
		width: 477,
		height: 592,
		webPreferences: {
			nodeIntegration: true,
		},
	});

	win.loadFile("index.html");
	win.setMenuBarVisibility(false);
};

app.whenReady().then(createWindow);
