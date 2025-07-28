# Cryptography Project: Simple Encryption Algorithms Simulator

This project implements a desktop application that simulates the encryption process using several classical cryptographic algorithms: Rail Fence, Myszkowski, and Playfair ciphers. The application includes user registration and login functionalities, with an emphasis on security through digital certificates and RSA key pairs for each user. It also features secure logging of simulation results and detects unauthorized file tampering.

## Project Description

This application serves as a simulator for various classical encryption algorithms. Users can register, log in securely, and then encrypt arbitrary text using supported ciphers. A core aspect of the project is its robust security model, incorporating digital certificates issued by a pre-established Certificate Authority (CA) and RSA key pairs for user authentication and data protection. All simulation results are securely logged into user-specific files, with mechanisms in place to detect any external, unauthorized modifications to these logs, ensuring both confidentiality and integrity.

## Features

### User Management
* **Registration**: Users register by providing a username and password. Upon registration, the application automatically generates a digital certificate and an RSA key pair for the user.
    * Certificate data is linked to user information.
    * Generated certificates and private keys are adequately protected.
* **Login**: A two-step authentication process:
    1.  User selects their digital certificate.
    2.  User enters their username and password.
* **User-Specific History**: Only the logged-in user can view their simulation history within the application.

### Encryption Algorithms
The application supports encryption (decryption is not required) using at least the following algorithms:
* **Rail Fence Cipher**
* **Myszkowski Cipher**
* **Playfair Cipher**
Users select an algorithm and input text for encryption.

### Secure Simulation Logging
* **Format**: Each simulation result is saved in a text file in the format: `PLAINTEXT | ALGORITHM | KEY | CIPHERTEXT`.
* **User-Specific Files**: A separate history file is created for each user.
* **Integrity and Confidentiality**: Files are protected against unauthorized external access.
* **Tampering Detection**: The application detects any unauthorized modifications to history files and notifies the respective user upon their next login.

### Public Key Infrastructure (PKI)
* The application assumes the existence of a PKI.
* All certificates are issued by a CA established prior to the application's operation.
* The CA certificate, CRL list, all user certificates, and the private key of the currently logged-in user are assumed to be located at arbitrary, accessible locations on the file system. (Key exchange mechanisms are not implemented).
