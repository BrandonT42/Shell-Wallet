# Shell-Wallet
Shell wallet is an RPC based client wallet application built for use on the Turtlecoin (TRTL) network.
Built using C# and window forms.

# IMPORTANT
Please know that Shell Wallet is currently in BETA stages and you should NOT use it to access your main wallet or any important funds. Keep in mind that this application is still being actively developed, and as such, there WILL be bugs, and many features will be added, changed, or even removed entirely.

# Donwload
See above warning.

Beta Version 0.6.4 : [Shell-Wallet-6.4.0.7z](https://github.com/BrandonT42/Shell-Wallet/raw/master/Binaries/Shell-Wallet-0.6.4.7z)

# Getting started

![Alt text](/Previews/Main.png?raw=true "Main Window")

1. When you first run Shell Wallet, you will be asked to choose where the RPC wallet server application is located on your system. This should be a file named "walletd.exe" located where ever you installed the Turtlecoin core files to. This is needed to run Shell Wallet.

![Alt_text](/Previews/Connectivity.png?raw=true "Connectivity")

2. Once you have located the RPC wallet server application, you are going to want to verify your daemon settings. This is in the options menu, under "General", then "Daemon Server". You can choose to connect using a local connection (default, you must run turtlecoind.exe and wait for it to fully sync before your wallet information will be accurate) or connest using a remote node. If you are connecting through a node, you will want to uncheck "Use local daemon" and enter the node address and port into  the proper boxes. Do not enter "http://", just enter the address or ip, such as "public.turtlenode.io".

3. While still in the options menu,  you are also able to choose which port you would like to bind the wallet server to, under "RPC Wallet Server" (Shell Wallet's default is 11911), as well as the option to choose whether you want to set your own user password (less secure, but lets you connect remotely using another RPC client), or let the server generate a unique hash as a password on each run (default). If you would like to set your own password, you must uncheck "Generate server password dynamically" under the Security tab.

![Alt_text](/Previews/Import.png?raw=true "Wallet Options")

4. Once you have your connection settings sorted out, you are able to open, create, or import a wallet - go ahead and click "Wallet" on the main menu, then choose which you would like to do. Instructions for each is listed below:

  * Open Wallet - When you click this option, an open file dialog will pop up. From here you will want to navigate to wherever your wallet file is located on your system and open it. Afterwards, you'll be prompted for a password. If your wallet has a password, enter it here, and then click "Submit", otherwise leave the password field blank and click "Submit", then after a brief password verification, your wallet should open. Please keep in mind that even if your wallet holds balance, you will need to sync completely before the displayed balance will be accurate.
  
  * Create Wallet - When you click this option, you will be given a save file dialog, where you will be able to name your wallet as you please. Please note, you cannot overwrite a file when creating or importing a wallet, it must be a new file. After you have chosen a location to save your new wallet file, you will be prompted to enter a password. Enter a password of your choice, then click submit, and your wallet should be created and then automatically opened in Shell Wallet for you.
  
  * Import Wallet - When you click this option, you will be prompted to enter both the secret view key and secret spend key for an existing wallet. Once entered, click "Import Keys", and you will be prompted to enter a password for your new wallet file. After entering a password and clicking "Submit", you will then be prompted to choose where you would like to save your newly imported wallet file. Please note, you cannot overwrite a file when creating or importing a wallet, it must be a new file. If the provided keys are accurate, a new wallet file will then be generated at the chosen location with te entered keys. Please keep in mind that even if your imported wallet holds balance, you will need to sync completely before the displayed balance will be accurate.
  
![Alt_text](/Previews/Password.png?raw=true "Password Prompt")

5. After opening your wallet file, if you don't already have your private keys backed up, back them up in case you ever lose access to your wallet file for some reason. Click "Wallet" in the main menu, then select "Export All Keys". You will be prompted to enter your password again for security purposes. Once your password has been entered and verified, you will be prompted to choose where you would like to save a text file containing your private keys. Choose a location, and click save. The newly created file will automaticaly be opened if successful.

![Alt_text](/Previews/InUse.png?raw=true "In Use")

6. All set! You should be good to go from here.
