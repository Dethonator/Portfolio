import os
def list_dir(path):
    files = os.listdir(path)
    return files

print(str(list_dir(os.getcwd())))
