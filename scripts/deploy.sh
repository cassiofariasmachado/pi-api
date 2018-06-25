#!/bin/bash

echo '#####################################'
echo '           Deploy started            '
echo '#####################################'

echo '-------------------------------------'
echo '            Build started            '
echo '-------------------------------------'

sh ./scripts/build.sh

echo '-------------------------------------'
echo '           Install started           '
echo '-------------------------------------'

sh ./scripts/install.sh

echo '#####################################'
echo '    Deploy completed with success    '
echo '#####################################'