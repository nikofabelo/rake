#!/usr/bin/env python3

import os
import sys # XXX

CHUNK_SIZE = 16777216 # XXX

def die(s): print(s); exit() # XXX

try:
    os.listdir("/root")
except:
    die("Run with root privileges!")

try:
    media = open(sys.argv[1], "rb")
except:
    die("Error!, couldn't open media for read access.")

# TODO ################################################# CODING AREA ################################################## XXX #
print(media.read(CHUNK_SIZE))
# TODO ################################################# CODING AREA ################################################## XXX #

media.close()