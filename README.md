# Encryption-and-Decryption
Open and run
1. Open the program via the "Encryption and Decryption.exe" file or open the project in Visual Studio and run it via it
2. After the visual interface opens, follow the following steps depending on your preferences

Symmetric algorithm
1. If we want to encrypt or decrypt the program with a symmetric algorithm, press the "AES Encryption and Decryption" button on the main menu
2. Using the three dots on the right side of the box under "File:" a dialog opens for selecting the file we want to manage
3. Select a text file in the dialog box

4. Encryption
4.1. In the case of encryption, after selecting a valid file, press the "Encrypt" button
4.2. Encrypted text and secret key files are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
4.3. The files are named: "aes_encrypted.txt" and "secret_key.txt"

5. Decryption
5.1. In the case of decryption, after selecting a valid file, open the dialog box for the secret key
5.2. Opening is achieved in the same way as selecting a file, but this time the button next to the box below the text of the secret key
5.3. After selecting a valid secret key, we can press the "Decrypt" button and decrypt the text
5.4. Decrypted text files are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
5.5. The file is named: "aes_decrypted.txt"

Asymmetric algorithm, hashing and digital signature
1. If we want to encrypt or decrypt the program with a symmetric algorithm, press the button "RSA Encryption and Decryption"
2. Using the three dots on the right side of the box under "File:" a dialog opens for selecting the file we want to manage
3. This file selection will be used for all further actions in this form
4. Select a text file in the dialog box (it is important that it is small in size)

5. Encryption
5.1. In the case of encryption, after selecting a valid file, press the "Encrypt" button
5.2. Files of encrypted text, private key and public key are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
5.3. The files are named: "rsa_encrypted.txt", "public_key.txt" and "private_key.txt"

6. Encryption using an external public key
6.1. In the case of encryption with the help of an external key, after selecting a valid file, the public key file should also be selected
6.2. After selecting a valid public key, press the "Encrypt" button
6.3. Files of encrypted text, private key and public key are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
6.4. The file is named: "rsa_encrypted.txt"

7. Decryption
7.1. In the case of decryption, after selecting a valid file, open the dialog box for the private key
7.2. Opening is achieved in the same way as selecting a file, but this time the button next to the box below the text of the private key
7.3. After selecting a valid private key, we can press the "Decrypt" button and decrypt the text
7.4. Decrypted text files are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
7.5. The file is named: "rsa_decrypted.txt"

8. Hashing
8.1. In the case of hashing, select a valid file and press the "Hash" button
8.2. The hashed text files are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
8.3. The file is named: "hash256.txt"

9. Signing
9.1. In the case of signing, select a valid file and press the "Sign" button
9.2. The files of the signed text are saved under the folder "Documents/Encryption and Decryption CookieTheory/"
9.3. The file is named: "rsa_digital_signature.txt"

10. Signature verification
10.1. In the case of signature verification, select valid files.
10.2. Under "Digital signature:" select the folder file, and under "File:" select the original encrypted file
10.3. By pressing the "Check signature" button, we get a confirmation under the button whether the signature is correct
