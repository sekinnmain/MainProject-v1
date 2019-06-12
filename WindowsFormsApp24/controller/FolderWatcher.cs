using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;

// Delegate:
public delegate void FolderObserver(string[] filesReport);

// The FolderWatcher class
public class FolderWatcher {

    private const int INTERVAL = 10000; // The interval, in mSec, between the folder's checks
    private const string FOLDER_DOESNT_EXIST_MESSAGE = "Folder doesn't exist.";
    private const string ADDED_FILES_HEADLINE = "Added File(s):";

    // The list of files found in the folder in the previous check:
    private List<string> preveiousFiles = new List<string>();
    // The array that holds the new files' names:
    private List<string> newFilesList = new List<string>(); 

    // Event:
    public event FolderObserver FolderChanged;

    private string folderName;  // The name of the folder to be watched
    bool firstTime = true;      // Is it the first time the folder is checked?

    // Constructor
    public FolderWatcher(string folderName) {
        this.folderName = folderName;
        new Timer(watchFolder, null, 0, INTERVAL);
    }

    // The watching method:
    private void watchFolder(object o) {
        // The parameter is not used, but is needed according to the TimerCallback delagate passed to the Timer constructor

        Console.WriteLine("."); // Just for debugging, to verify that the method is called
        if (!Directory.Exists(folderName)) {
            // The folder doesn't exist
            if (firstTime) {
                // It's the first time this method
                // is invoked, so call the user's method with the appropriate message:
                FolderChanged(new string[] { FOLDER_DOESNT_EXIST_MESSAGE });
                firstTime = false;
            }
        } else {
            newFilesList.Clear();
            newFilesList.Add(ADDED_FILES_HEADLINE);
            string[] existingFiles = Directory.GetFiles(folderName);

            foreach (string fileName in existingFiles) {
                if (!preveiousFiles.Contains(fileName)) {
                    newFilesList.Add(Path.GetFileName(fileName));
                    preveiousFiles.Add(fileName);
                }
            } // end foreach

            if (!(newFilesList.Count == 1)) // If any file added
                if (firstTime) {
                    firstTime = false;
                } else if (FolderChanged != null) {
                    FolderChanged(newFilesList.ToArray());
                }
        } // end if-else
    } // end method watchFolder
} // end class FolderWatcher
